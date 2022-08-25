import React, { Component } from 'react';
import './App.css';
import { useState, useEffect, useRef } from "react";


function App() {
    const [maker, setCar] = useState();
    const [data, setData] = useState(null);
    useEffect(() => {
        fetch(`https://localhost:7287/api/Cars`
        ).then((response) => response.json())
            .then(setData);
    }, []);

    if (data) console.log('there is data!');
    
    return (
        <>
            <h1>{data[0].name}</h1>
        </>
    )
}

export default App;