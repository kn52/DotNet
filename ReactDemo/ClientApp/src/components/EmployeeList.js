import React, { Component } from 'react';

export class EmployeeList extends Component {
    displayName = EmployeeList.name

    constructor(props) {
        super(props);
        this.state = { employeedata: [], loading: true };

        fetch('api/Employee/GetEmployees')
            .then(response => response.json())
            .then(data => {
                this.setState({ employeelist: data, loading: false });
            });
    }

    GetEmployee(id) {
        this.props.history.push('/employeedata');
    }

    static renderForecastsTable(data) {
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    {data.map(e =>
                        <tr key={e.id}>
                            <td>{e.id}</td>
                            <td>{e.firstName + " " + e.lastName}</td>
                            <td><button type="button" onclick="GetEmployee(e.id)">View Details</button></td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : EmployeeList.renderForecastsTable(this.state.employeelist);

        return (
            <div>
                <h1>Employee List</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }
}