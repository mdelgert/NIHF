import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { FetchPart } from './components/FetchPart';
import { AddPart } from './components/AddPart';

export const routes = <Layout>
    <Route exact path='/' component={FetchPart} />
    <Route path='/fetchpart' component={FetchPart} />
    <Route path='/addpart' component={AddPart} />
    <Route path='/part/update/:id' component={AddPart} />
</Layout>;
