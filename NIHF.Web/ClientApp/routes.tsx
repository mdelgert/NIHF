import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchPart } from './components/FetchPart';
import { AddPart } from './components/AddPart';
import { FetchManufacture } from './components/FetchManufacture';
import { AddManufacture } from './components/AddManufacture';

export const routes = <Layout>
    <Route exact path='/' component={ Home } />
    <Route path='/fetchmanufacture' component={FetchManufacture} />
    <Route path='/addmanufacture' component={AddManufacture} />
    <Route path='/fetchpart' component={FetchPart} />
    <Route path='/addpart' component={AddPart} />
    <Route path='/part/update/:id' component={AddPart} />
</Layout>;
