import React from 'react';
import logo from './logo.svg';
import './App.css';

function App() {
  return (
    <div className="App">
      <h2>My Web Application</h2>
      <nav>
        <a href="/">Home</a>
        {' | '}
        <a href="/orders">Orders</a>
        {' | '}
        <a href="/payments">Payments</a>
      </nav>
      <hr />

      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;