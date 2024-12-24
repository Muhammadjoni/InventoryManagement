import React from 'react';
import './ProductsTable.css';

function ProductsTable() {
  const products = [
    { id: 1, name: 'Product 1', category: 'Category 1', supplier: 'Supplier 1', quantity: 100 },
    { id: 2, name: 'Product 2', category: 'Category 2', supplier: 'Supplier 2', quantity: 200 },
    // Add more products as needed
  ];

  return (
    <div className="products-table">
      <h2>Products</h2>
      <table>
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Category</th>
            <th>Supplier</th>
            <th>Quantity</th>
          </tr>
        </thead>
        <tbody>
          {products.map(product => (
            <tr key={product.id}>
              <td>{product.id}</td>
              <td>{product.name}</td>
              <td>{product.category}</td>
              <td>{product.supplier}</td>
              <td>{product.quantity}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default ProductsTable;