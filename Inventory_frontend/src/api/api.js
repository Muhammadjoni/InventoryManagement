const BASE_URL = 'http://your-backend-api-url'; // Replace with your backend API URL

// Products API
export const getProducts = async () => {
  const response = await fetch(`${BASE_URL}/products`);
  if (!response.ok) {
    throw new Error('Failed to fetch products');
  }
  return response.json();
};

export const createProduct = async (product) => {
  const response = await fetch(`${BASE_URL}/products`, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(product),
  });
  if (!response.ok) {
    throw new Error('Failed to create product');
  }
  return response.json();
};

export const updateProduct = async (id, product) => {
  const response = await fetch(`${BASE_URL}/products/${id}`, {
    method: 'PUT',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(product),
  });
  if (!response.ok) {
    throw new Error('Failed to update product');
  }
  return response.json();
};

export const deleteProduct = async (id) => {
  const response = await fetch(`${BASE_URL}/products/${id}`, {
    method: 'DELETE',
  });
  if (!response.ok) {
    throw new Error('Failed to delete product');
  }
  return response.json();
};

// Categories API
export const getCategories = async () => {
  const response = await fetch(`${BASE_URL}/categories`);
  if (!response.ok) {
    throw new Error('Failed to fetch categories');
  }
  return response.json();
};

export const createCategory = async (category) => {
  const response = await fetch(`${BASE_URL}/categories`, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(category),
  });
  if (!response.ok) {
    throw new Error('Failed to create category');
  }
  return response.json();
};

export const updateCategory = async (id, category) => {
  const response = await fetch(`${BASE_URL}/categories/${id}`, {
    method: 'PUT',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(category),
  });
  if (!response.ok) {
    throw new Error('Failed to update category');
  }
  return response.json();
};

export const deleteCategory = async (id) => {
  const response = await fetch(`${BASE_URL}/categories/${id}`, {
    method: 'DELETE',
  });
  if (!response.ok) {
    throw new Error('Failed to delete category');
  }
  return response.json();
};

// Suppliers API
export const getSuppliers = async () => {
  const response = await fetch(`${BASE_URL}/suppliers`);
  if (!response.ok) {
    throw new Error('Failed to fetch suppliers');
  }
  return response.json();
};

export const createSupplier = async (supplier) => {
  const response = await fetch(`${BASE_URL}/suppliers`, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(supplier),
  });
  if (!response.ok) {
    throw new Error('Failed to create supplier');
  }
  return response.json();
};

export const updateSupplier = async (id, supplier) => {
  const response = await fetch(`${BASE_URL}/suppliers/${id}`, {
    method: 'PUT',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(supplier),
  });
  if (!response.ok) {
    throw new Error('Failed to update supplier');
  }
  return response.json();
};

export const deleteSupplier = async (id) => {
  const response = await fetch(`${BASE_URL}/suppliers/${id}`, {
    method: 'DELETE',
  });
  if (!response.ok) {
    throw new Error('Failed to delete supplier');
  }
  return response.json();
};