import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { FetchPart } from './components/FetchPart';
import { AddPart } from './components/AddPart';
import { Counter } from './components/Counter';
import { FetchManufacture } from './components/FetchManufacture';
import { AddManufacture } from './components/AddManufacture';

export const routes = <Layout>
    <Route exact path='/' component={ Home } />
    <Route path='/counter' component={ Counter } />
    <Route path='/fetchdata' component={FetchData} />
    <Route path='/fetchpart' component={FetchPart} />
    <Route path='/addpart' component={AddPart} />
    <Route path='/fetchmanufacture' component={FetchManufacture} />
    <Route path='/addmanufacture' component={AddManufacture} />
</Layout>;
