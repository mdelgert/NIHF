import * as React from 'react';
import { RouteComponentProps } from 'react-router';

interface FetchManufactureDataState {
    manufacture: ManufactureData[];
    loading: boolean;
}

export class ManufactureData {
    id: number = 0;
    name: string = "";
} 
export class AddManufacture extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        let contents = this.renderCreateForm();
        return <div>
            <p>Add Manufacture</p>
            {contents}
        </div>;
    }

    private handleSave(event) {
        event.preventDefault();
        const data = new FormData(event.target);
        fetch('api/Manufacturer/Create', {
            method: 'POST',
            body: data,
        })
    }

    private renderCreateForm() {
        return (
            <form onSubmit={this.handleSave} >
                < div className="form-group row" >
                    <label className=" control-label col-md-12" htmlFor="Name">Name</label>
                    <div className="col-md-4">
                        <input className="form-control" type="text" name="name" defaultValue="" required />
                    </div>
                </div >
                <div className="form-group">
                    <button type="submit" className="btn btn-default">Save</button>
                </div >
            </form >
        )
    }
}
