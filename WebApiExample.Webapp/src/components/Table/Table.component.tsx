import './Table.scss';

import React, { useEffect, useState } from 'react';

interface IProps { data: any }
function TableComponent(props: IProps) {
    const [dataState, setDataState] = useState([]);
    const refTxtEmployeeName = React.createRef<HTMLInputElement>();
    const refTxtContactNumber = React.createRef<HTMLInputElement>();
    const refTxtEmail = React.createRef<HTMLInputElement>();
    const refTxtSector = React.createRef<HTMLInputElement>();
    const refDataBody = React.createRef<HTMLDivElement>();

    const columnClassNames = (type: 'header' | 'body', size?: any, align?: 'left' | 'center' | 'right') => {
        return `table__${type}__line__column  col__${size ?? 20}__${align ?? 'left'}`;
    }

    useEffect(() => {

        if (props.data.length > 0) {
            setDataState(props.data);
        }

    }, [props]);

    const filterTable = () => {
        let filteredData: any = [];

        refTxtEmployeeName.current?.classList.remove("active");
        refTxtContactNumber.current?.classList.remove("active");
        refTxtEmail.current?.classList.remove("active");
        refTxtSector.current?.classList.remove("active");

        if (refTxtEmployeeName.current?.value !== "") {
            refTxtEmployeeName.current?.classList.add("active");
        }
        if (refTxtContactNumber.current?.value !== "") {
            refTxtContactNumber.current?.classList.add("active");
        }
        if (refTxtEmail.current?.value !== "") {
            refTxtEmail.current?.classList.add("active");
        }
        if (refTxtSector.current?.value !== "") {
            refTxtSector.current?.classList.add("active");
        }

        filteredData = props.data.filter(
            (item: any) =>
                item.nameFull.toString().toLowerCase().indexOf(refTxtEmployeeName.current?.value.toString().toLowerCase()) !== -1 &&
                item.contactNumber.toString().toLowerCase().indexOf(refTxtContactNumber.current?.value.toString().toLowerCase()) !== -1 &&
                item.email.toString().toLowerCase().indexOf(refTxtEmail.current?.value.toString().toLowerCase()) !== -1 &&
                item.nameSector.toString().toLowerCase().indexOf(refTxtSector.current?.value.toString().toLowerCase()) !== -1
        );

        refDataBody.current?.childNodes.forEach((element: any) => {
            if (filteredData.filter((item: any) => ("employeeLine_" + item.idEmployee) === element.id).length === 0) {
                element.classList.add("hide");

                setTimeout(() => {
                    element.classList.add("remove");
                }, 500);

            } else {
                element.classList.remove("remove");

                setTimeout(() => {
                    element.classList.remove("hide");
                }, 100);

            }
        });

        //  setDataState(filteredData);
    }

    return (

        <section className="table row no__sides__padding">
            <section className="table__search row__stretch col__100">
                <div className="table__search__field no__padding__left">
                    <div className="table__search__field__name  col__100">Employee name</div>
                    <div className="table__search__field__input col__100">
                        <input ref={refTxtEmployeeName} id="txtEmployeeName" type="text" className="" onChange={filterTable} />
                    </div>
                </div>
                <div className="table__search__field">
                    <div className="table__search__field__name col__100">Contact number</div>
                    <div className="table__search__field__input col__100">
                        <input ref={refTxtContactNumber} id="txtContactNumber" type="text" className="" onChange={filterTable} />
                    </div>
                </div>
                <div className="table__search__field">
                    <div className="table__search__field__name col__100">Email</div>
                    <div className="table__search__field__input col__100">
                        <input ref={refTxtEmail} id="txtEmail" type="text" className="" onChange={filterTable} />
                    </div>
                </div>
                <div className="table__search__field">
                    <div className="table__search__field__name col__100">Sector</div>
                    <div className="table__search__field__input col__100">
                        <input ref={refTxtSector} id="txtSectorName" type="text" className="" onChange={filterTable} />
                    </div>
                </div>

            </section>
            <section className="table__header  col__auto" >
                <div className={columnClassNames('header', 15)}> </div>
                <div className={columnClassNames('header', 15)}> Employee name</div>
                <div className={columnClassNames('header', 20)}>Contact number </div>
                <div className={columnClassNames('header', 30)}> Email</div>
                <div className={columnClassNames('header', 10)}> Sector</div>
            </section>
            <section ref={refDataBody} className="table__body row no__padding__right col__100" >
                {
                    dataState?.map((items: any) =>
                        <div key={`employee_${items.idEmployee}`}
                            id={`employeeLine_${items.idEmployee}`}
                            className="table__body__line__column table__body__line--hover no__sides__padding col__100">

                            <div className={`thumbnail ${columnClassNames('body', 15)}`}>
                                <img src={`images/${items.thumbnail}`} alt={`Employee thumbnail ${items.nameFull}`} className="no__sides__padding" />
                            </div>
                            <div className={columnClassNames('body', 15)}>
                                {items.nameFull}
                            </div>
                            <div className={columnClassNames('body', 20)}>
                                {items.contactNumber}
                            </div>
                            <div className={columnClassNames('body', 30)}>
                                {items.email}
                            </div>
                            <div className={columnClassNames('body', 10)}>
                                {items.nameSector}
                            </div>

                        </div>)
                }
            </section>
            <footer className="table__footer col__100">
                <div className="table__footer__count  no__sides__padding col__auto__right">
                    Employees: {props.data.length}
                </div>
            </footer>

        </section>

    )
};

export default TableComponent;