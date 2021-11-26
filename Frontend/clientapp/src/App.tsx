import React from "react";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";

import Homepage from "./Pages/Home";
import Userpage from "./Pages/User";
import Searchpage from "./Pages/Search";

import "./Style/App.css";
import { Navbar } from "./Components/Navbar";

function App() {
    return (
        <Router>
            <Navbar />
            <div>
                <div className="page-body">
                    <Switch>
                        <Route path="/search">
                            <Searchpage />
                        </Route>
                        <Route path="/user">
                            <Userpage />
                        </Route>
                        <Route path="/">
                            <Homepage />
                        </Route>
                    </Switch>
                </div>
            </div>
        </Router>
    );
}

export default App;
