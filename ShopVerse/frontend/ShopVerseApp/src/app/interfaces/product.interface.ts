export interface Product {
  productId: number;
  productName: string;
  description: string;
  price: number;
  stock: number;
  category: string;
  imageUrl: string;
  sku: string;
  createdDate: Date;
}

export interface UpdateProductDto {
  productName: string;
  Description: string;
  Price: number;
  stock: number;
  category: string;
  imageUrl: string;
  sku: string;
}

export interface CreateProductDto {
  productName: string;
  Description: string;
  Price: number;
  stock: number;
  category: string;
  imageUrl: string;
  sku: string;
}
