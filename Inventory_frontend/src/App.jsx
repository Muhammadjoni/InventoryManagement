import { useState } from 'react';
import reactLogo from './assets/react.svg';
import viteLogo from '/vite.svg';
import './App.css';
import Header from './components/Header/Header';
import Footer from './components/Footer/Footer';
import Navbar from './components/Navbar/Navbar';
import Banner from './components/Banner/Banner';
import InventoryList from './components/InventoryList';
import ProductsTable from './components/ProductsTable/ProductsTable';
function App() {
  const [count, setCount] = useState(0);

  return (
    <>
      <Header />
      <Navbar />
      <Banner />
      <div className="container">
        <h1>Inventory Management System</h1>
        <ProductsTable />
        <InventoryList />
      </div>
      <Footer />
    </>
  );
}

export default App;