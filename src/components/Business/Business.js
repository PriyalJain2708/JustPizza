import React from "react";
import "./Business.css";

class Business extends React.Component {
  render() {
    return (
      <div className="Business">
          <div className="image-container">
            <img src={this.props.pizzaDetailList.img} alt="" />
        </div>
        <h2>{this.props.pizzaDetailList.name}</h2>
        <div className="Business-information">
          <div className="Business-address">
            <p>{this.props.pizzaDetailList.address}</p>
            <p>{this.props.pizzaDetailList.city}</p>
            <p>
              {this.props.pizzaDetailList.state} {this.props.pizzaDetailList.zipCode}
            </p>
          </div>
          <div className="Business-reviews">
            <h3>{this.props.pizzaDetailList.category}</h3>
            <h3 className="rating">{this.props.pizzaDetailList.rating} stars</h3>
            <p>{this.props.pizzaDetailList.reviewCount} reviews</p>
          </div>
        </div>
      </div>
    );
  }
}

export default Business;
