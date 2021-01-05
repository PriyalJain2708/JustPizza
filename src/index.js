import React from "react";
import ReactDOM from "react-dom";
import BusinessList from "./components/BusinessList/BusinessList.js";
import SearchBar from "./components/SearchBar/SearchBar.js";
import Login from "./components/Login";
import SignUp from "./components/signup";
import ForgotPassword from "./components/forgotpassword";

import {
  BrowserRouter as Router,
  Switch,
  Route,
  Redirect,
  Link,
  useRouteMatch,
  useParams
} from "react-router-dom";

import "./styles.css";

function App() {
  
  return (
<div className="App">
      <h1 style = {{backgroundColor: '#1bbd7e'}}>Just Pizza !!</h1>
  <Router>
    <Switch>
    <Route exact path="/login">
      <Login />
    </Route>
    <Route exact path="/signup">
      <SignUp />
    </Route>
    <Route exact path="/forgotpassword">
      <ForgotPassword />
    </Route>
    <Route exact path="/SearchBar">
      <SearchBar />
    </Route>
    <Route exact path="/BusinessList">
      <BusinessList />
    </Route>
    <Redirect from="*" to="/login" />
   
    </Switch>
</Router> 
</div>
  );
}

const rootElement = document.getElementById("root");
ReactDOM.render(<App />, rootElement);
