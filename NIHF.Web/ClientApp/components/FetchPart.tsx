import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
//import 'isomorphic-fetch';

interface FetchPartState {
    parts: Part[];
    loading: boolean;
}

export class FetchPart extends React.Component<RouteComponentProps<{}>, FetchPartState> {
    constructor() {
        super();
        this.state = { parts: [], loading: true };

        fetch('api/Part/Index')
            .then(response => response.json() as Promise<Part[]>)
            .then(data => {
                this.setState({ parts: data, loading: false });
            });

        // This binding is necessary to make "this" work in the callback
        this.handleDelete = this.handleDelete.bind(this);

    }

    public render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderPartsTable(this.state.parts);

        return <div>
            <h1>Parts</h1>
            <p>This component demonstrates fetching data from the server.</p>
            <p>
                <Link to="/addpart">Create New</Link>
            </p>
            {contents}
        </div>;
    }

    // Handle Delete request for an employee
    private handleDelete(id: number) {
        if (!confirm("Do you want to delete part with Id: " + id))
            return;
        else {
            fetch('api/Part/Delete/' + id, {
                method: 'delete'
            }).then(data => {
                this.setState(
                    {
                        parts: this.state.parts.filter((rec) => {
                            return (rec.id != id);
                        })
                    });
            });
        }
    }

    private renderPartsTable(parts: Part[]) {
        return <table className='table'>
            <thead>
                <tr>
                    <th>Number</th>
                    <th>Name</th>
                </tr>
            </thead>
            <tbody>
                {parts.map(part =>
                    <tr key={part.id}>
                        <td>{part.number}</td>
                        <td>{part.name}</td>
                        <td>
                            
                            <a className="action" onClick={(id) => this.handleDelete(part.id)}>Delete</a>
                        </td>
                    </tr>
                )}
            </tbody>
        </table>;
    }
}

export class Part {
    id: number = 0;
    number: string;
    name: string;
    description: string;
}
