import React from "react";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";

import { Homepage as Home } from "./Pages/Home";
import { Userpage as User } from "./Pages/User";
import { Searchpage as Search } from "./Pages/Search";

import "./Style/App.css";
import { Navbar } from "./Components/Navbar";

function App() {
    return (
        <Router>
            <div>
                <Navbar />
                <div className="page-body">
                    <Switch>
                        <Route path="/search">
                            <Search />
                        </Route>
                        <Route path="/user">
                            <User />
                        </Route>
                        <Route path="/">
                            <Home />
                        </Route>
                    </Switch>
                </div>
            </div>
        </Router>
    );
}

export default App;
