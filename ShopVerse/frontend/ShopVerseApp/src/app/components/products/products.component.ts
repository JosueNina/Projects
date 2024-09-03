import { Component, OnInit } from '@angular/core';
import { Product } from '../../interfaces/product.interface';
import { ProductService } from '../../services/product.service';
import { ProductComponent } from './product/product.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-products',
  standalone: true,
  imports: [ProductComponent, CommonModule],
  templateUrl: './products.component.html',
  styleUrl: './products.component.css',
})
export class ProductsComponent implements OnInit {
  productList: Product[] = [];

  constructor(private _productService: ProductService) {}

  ngOnInit(): void {
    this._productService.getAll().subscribe((res) => {
      this.productList = res;
      console.log(this.productList);
    });
  }
}
