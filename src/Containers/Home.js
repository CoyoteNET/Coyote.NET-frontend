import React, { Component } from 'react';
import Category from '../Components/Category'

const Simpledata = ["First Category", "Second Category", "Third Category", "Fourth Category"];

class Home extends Component{

    getCategories(){
        const preparedData = Simpledata.map((category, index) =>
            <Category data={category} key={index}/>
        );
        return preparedData;
    }

    render(){
        return(
            <div>
                {this.getCategories()}
            </div>
        );
    }
}

export default Home