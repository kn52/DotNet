import React, { Component } from 'react';

export class EmployeeData extends Component {
    displayName = EmployeeData.name

    constructor(props) {
        super(props);
        this.state = { employeedata: [], loading: true };

        fetch('api/Employee/GetEmployees')
            .then(response => response.json())
            .then(data => {
                this.setState({ employeedata: data, loading: false });
            });
    }

    static renderForecastsTable(data) {
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Email</th>
                        <th>Password</th>
                        <th>Gender</th>
                        <th>Phone Number</th>
                    </tr>
                </thead>
                <tbody>
                    {data.map(e =>
                        <tr key={e.id}>
                            <td>{e.firstName}</td>
                            <td>{e.lastName}</td>
                            <td>{e.email}</td>
                            <td>{e.password}</td>
                            <td>{e.gender}</td>
                            <td>{e.phoneNumber}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : EmployeeData.renderForecastsTable(this.state.employeedata);

        return (
            <div>
                <h1>Employee Data</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }
}
