import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';

interface FetchManufactureDataState {
    manufactureList: ManufactureData[];
    loading: boolean;
}

export class FetchManufacture extends React.Component<RouteComponentProps<{}>, FetchManufactureDataState> {
    constructor() {
        super();
        this.state = { manufactureList: [], loading: true };

        fetch('api/Manufacturer/Index')
            .then(response => response.json() as Promise<ManufactureData[]>)
            .then(data => {
                this.setState({ manufactureList: data, loading: false });
            });
        // This binding is necessary to make "this" work in the callback
        this.handleDelete = this.handleDelete.bind(this);
    }

    public render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderManufactureTable(this.state.manufactureList);

        return <div>
            <h1>Manufacture Data</h1>
            {contents}
        </div>;
    }

    // Handle Delete request for an employee
    private handleDelete(id: number) {
        if (!confirm("Do you want to delete manufacture with Id: " + id))
            return;
        else {
            fetch('api/Manufacturer/Delete/' + id, {
                method: 'delete'
            }).then(data => {
                this.setState(
                    {
                        manufactureList: this.state.manufactureList.filter((rec) => {
                            return (rec.id != id);
                        })
                    });
            });
        }
    }

    // Returns the HTML table to the render() method.
    private renderManufactureTable(manufactureList: ManufactureData[]) {
        return <table className='table'>
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                </tr>
            </thead>
            <tbody>
                {manufactureList.map(manufacture =>
                    <tr key={manufacture.id}>
                        <td>{manufacture.id}</td>
                        <td>{manufacture.name}</td>
                        <td> 
                            <a className="action" onClick={(id) => this.handleDelete(manufacture.id)}>Delete</a>
                        </td>
                    </tr>
                )}
            </tbody>
        </table>;
    }
}

export class ManufactureData {
    id: number = 0;
    name: string = "";
} 