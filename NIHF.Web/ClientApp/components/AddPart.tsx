import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
import { PartData } from './fetchpart';

interface AddPartDataState {
    title: string;
    loading: boolean;
    manufactureList: Array<any>;
    partData: PartData;
}

export class AddPart extends React.Component<RouteComponentProps<{}>, AddPartDataState> {
    constructor(props) {
        super(props);

        this.state = { title: "", loading: true, manufactureList: [], partData: new PartData };

        fetch('api/Manufacturer/Index')
            .then(response => response.json() as Promise<Array<any>>)
            .then(data => {
                this.setState({ manufactureList: data });
            });

        var id = this.props.match.params["id"];

        // This will set state for Edit part
        if (id > 0) {
            fetch('api/Part/Read/' + id)
                .then(response => response.json() as Promise<PartData>)
                .then(data => {
                    this.setState({ title: "Edit", loading: false, partData: data });
                });
        }

        // This will set state for Add part
        else {
            this.state = { title: "Create", loading: false, manufactureList: [], partData: new PartData };
        }

        // This binding is necessary to make "this" work in the callback
        this.handleSave = this.handleSave.bind(this);
        this.handleCancel = this.handleCancel.bind(this);
    }

    public render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderCreateForm(this.state.manufactureList);

        return <div>
            <h1>{this.state.title}</h1>
            <h3>Part</h3>
            <hr />
            {contents}
        </div>;
    }

    // This will handle the submit form event.
    private handleSave(event) {
        event.preventDefault();
        const data = new FormData(event.target);

        // PUT request for Edit part.
        if (this.state.partData.id) {
            fetch('api/Part/Update', {
                method: 'PUT',
                body: data,

            }).then((response) => response.json())
                .then((responseJson) => {
                    this.props.history.push("/fetchpart");
                })
        }

        // POST request for Add part.
        else {
            fetch('api/Part/Create', {
                method: 'POST',
                body: data,

            }).then((response) => response.json())
                .then((responseJson) => {
                    this.props.history.push("/fetchpart");
                })
        }
    }

    // This will handle Cancel button click event.
    private handleCancel(e) {
        e.preventDefault();
        this.props.history.push("/fetchpart");
    }

    // Returns the HTML Form to the render() method.
    private renderCreateForm(manufactureList: Array<any>) {
        return (
            <form onSubmit={this.handleSave} >
                <div className="form-group row" >
                    <input type="hidden" name="id" value={this.state.partData.id} />
                </div>
                < div className="form-group row" >
                    <label className=" control-label col-md-12" htmlFor="Name">Name</label>
                    <div className="col-md-4">
                        <input className="form-control" type="text" name="name" defaultValue={this.state.partData.name} required />
                    </div>
                </div >
                <div className="form-group row">
                    <label className="control-label col-md-12" htmlFor="Description" >Description</label>
                    <div className="col-md-4">
                        <input className="form-control" type="text" name="Department" defaultValue={this.state.partData.description} required />
                    </div>
                </div>
                <div className="form-group row">
                    <label className="control-label col-md-12" htmlFor="Manufacture">Manufacture</label>
                    <div className="col-md-4">
                        <select className="form-control" data-val="true" name="Manufacture" defaultValue={this.state.partData.manufacturer} required>
                            <option value="">-- Manufacture --</option>
                            {manufactureList.map(manufacture =>
                                <option key={manufacture.id} value={manufacture.name}>{manufacture.name}</option>
                            )}
                        </select>
                    </div>
                </div >
                <div className="form-group">
                    <button type="submit" className="btn btn-default">Save</button>
                    <button className="btn" onClick={this.handleCancel}>Cancel</button>
                </div >
            </form >
        )
    }
}
