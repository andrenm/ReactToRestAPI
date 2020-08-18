import './plugins/Responsive-framework.scss';
import './App.scss';

import React from 'react';
import { BrowserRouter, Switch, Route } from 'react-router-dom';
import Employees from './pages/employees/Employees.template';

function App() {
  return (
    <BrowserRouter>
    <section className="app">
      <Switch>
        <Route exact path="/" component={Employees} />
        <Route path="/Employees" component={Employees} />
      </Switch>
    </section>
  </BrowserRouter>
  );
}

export default App;
