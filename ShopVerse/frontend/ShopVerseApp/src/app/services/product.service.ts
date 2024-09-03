import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {
  CreateProductDto,
  Product,
  UpdateProductDto,
} from '../interfaces/product.interface';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  private baseUrl: string = 'http://localhost:5227/api/Product';

  constructor(private _httpClient: HttpClient) {}

  public getAll(): Observable<Product[]> {
    return this._httpClient.get<Product[]>(`${this.baseUrl}`);
  }

  public getById(id: number): Observable<Product> {
    return this._httpClient.get<Product>(`${this.baseUrl}/${id}`);
  }

  public create(data: CreateProductDto): Observable<Product> {
    return this._httpClient.post<Product>(`${this.baseUrl}`, data);
  }

  public update(data: UpdateProductDto, id: number): Observable<Product> {
    return this._httpClient.put<Product>(`${this.baseUrl}/${id}`, data);
  }

  public delete(id: number): Observable<boolean> {
    return this._httpClient.delete<boolean>(`${this.baseUrl}/${id}`);
  }
}
