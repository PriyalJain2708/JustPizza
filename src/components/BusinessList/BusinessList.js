import React from "react";
import "./BusinessList.css";
import Business from "../Business/Business";
import Axios from 'axios';

class BusinessList extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      pizzaDetailList: [],
    }
  }
    componentDidMount() { 
      var requestOptions = {
        method: 'GET',
        redirect: 'follow'
      }; 
      Axios.get("https://localhost:44349/api/WebApi/").then(response => {  
          this.setState({  
            pizzaDetailList: response.data
          });  
      });  
  }  
  render() {
    return (
      <div className="BusinessList">
        <Business pizzaDetailList={this.state.pizzaDetailList}/>
        <Business pizzaDetailList={this.state.pizzaDetailList}/>
        <Business pizzaDetailList={this.state.pizzaDetailList}/>
      </div>
    );
  }
}
export default BusinessList;
