import './Employees.scss';

import React, { useEffect, useState } from 'react';
import { ConfigurationApiService, ControllersConfig } from '../../api/index.config';
import TableComponent from '../../components/Table/Table.component';

function EmployeesTemplate() {
    const [employeesState, setEmployeesState] = useState([]);

    useEffect(() => {
        ConfigurationApiService.getAll(ControllersConfig.employees).then((response) => {
            setEmployeesState(response)
        });

    }, []);

    return (
        <section className="page employee row">
            <div className="tableComponent col__80__center">
                <TableComponent data={employeesState} ></TableComponent>
            </div>
            <div className="bkgImages col__100">
                <img id="bkg_1" src="images/bkg_1.svg" alt="" />
                <img id="bkg_2" src="images/bkg_2.svg" alt="" />
            </div>
        </section>
    )
};

export default EmployeesTemplate;