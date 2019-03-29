import React, { Component } from 'react';

class Category extends Component{

    render(){
        return(
            <div className="category">
            {this.props.data}
            </div>
        );
    }
}

export default Category