export interface Product {
  productId: number;
  productName: string;
  description: string;
  price: number;
  createdDate: Date;
}

export interface UpdateProductDto {
  productName: string;
  Description: string;
  Price: number;
}

export interface CreateProductDto {
  productName: string;
  Description: string;
  Price: number;
}
