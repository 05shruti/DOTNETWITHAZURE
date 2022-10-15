import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Product} from './product';
import { Observable } from 'rxjs';
import { Category } from '../site-layout/category';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  constructor(private httpClient: HttpClient) { }

  getAllProducts(): Observable<Product>{
    const productUrl = 'http://localhost:3000/product';

    return this.httpClient.get<Product>(productUrl); // return an observable
  }

  getCategories(): Observable<Category>{
    const categoriesUrl = "http://localhost:3000/categories";
    return this.httpClient.get<Category>(categoriesUrl);
  }

  createProduc(productId: any): Observable<Product>{
    const productUrl = 'http://localhost:3000/product';

    return this.httpClient.post<Product>(productUrl, productId); // return an observable
  }

  viewProduct(productId:  number): Observable<Product>{
    const productUrl = 'http://localhost:3000/product/'+ productId;
    return this.httpClient.get<Product>(productUrl); // return an observable
  }

  updateProduct(productId:  number): Observable<Product>{
    const productUrl = 'http://localhost:3000/product/' + productId;
    return this.httpClient.put<Product>(productUrl, productId); // return an observable
  }

  deleteProduct(productId: number): Observable<Product>{
    const productUrl = 'http://localhost:3000/product/' + productId;
    return this.httpClient.delete<Product>(productUrl); // return an observable
  }

  searchCategoryProducts(categoryId: string|number): Observable<Product>{
    const productUrl = 'http://localhost:3000/products?categoryId='+categoryId;
    return this.httpClient.get<Product>(productUrl); // return an observable
  }

  searchDateProducts(dateParam: string): Observable<Product>{
    const productUrl = 'http://localhost:3000/product/date='+dateParam;
    return this.httpClient.get<Product>(productUrl); // return an observable
  }

}
