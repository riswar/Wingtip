import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DecimalPipe } from '@angular/common';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html'
})
export class ProductComponent {
  public products: product[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<product[]>(baseUrl + 'api/product').subscribe(result => {
      this.products = result;
    }, error => console.error(error));
  }
}

interface product {
  productId: number;
  ProductName: string;
  imagePath: string;
  unitPrice: DecimalPipe;
}
