import { HttpClient } from '@angular/common/http';
import { inject ,Injectable, signal } from '@angular/core';
import { AddCategoryRequest } from '../models/category.models';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
    private http= inject(HttpClient)
    private apiBaseUrl= 'https://localhost:7243';


    addCategoryStatus = signal<'idle' | 'loading' | 'error' | 'success'>('idle');

    addCategory(category: AddCategoryRequest){
      this.addCategoryStatus.set('loading');
      this.http.post<void>(`${this.apiBaseUrl}/api/categories`, category).subscribe({
        next:() =>{},
        error:()=>{},
      });
    }

}
