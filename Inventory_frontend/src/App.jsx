import './App.css';
import Header from './components/Header/Header';
import Footer from './components/Footer/Footer';
import Navbar from './components/Navbar/Navbar';
import Banner from './components/Banner/Banner';
import ProductsTable from './components/ProductsTable/ProductsTable';
import CategoriesTable from './components/CategoriesTable/CategoriesTable';


function App() {
  return (
    <>
      <Header />
      <Navbar />
      <Banner />
      <div className="container">
        <h1>Inventory Management System</h1>
        <ProductsTable />
        <CategoriesTable />
      </div>
      <Footer />
    </>
  );
}

export default App;