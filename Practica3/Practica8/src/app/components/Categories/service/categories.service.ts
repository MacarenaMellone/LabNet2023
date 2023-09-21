import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { categoriesDto } from 'src/app/core/models/categoriesDto';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {
  endpoint: string = 'Categories';
  apiUrl: string = environment.webApi + this.endpoint;

  constructor(private http: HttpClient) { }

  public getAllCategories(): Observable<Array<categoriesDto>> {
    return this.http.get<Array<categoriesDto>>(this.apiUrl);
  }
  
  public postCategories(categoriesDto:categoriesDto): Observable <any>{
    return this.http.post(this.apiUrl, categoriesDto);
  } 

  public updateCategories(categoriesDto: categoriesDto): Observable<Object> {
    return this.http.put(this.apiUrl, categoriesDto);
  }

  public deleteCategories(CategoryID: number): Observable<Object> {
    return this.http.delete<number>(this.apiUrl + "/" + CategoryID);
  }

  public getCategoriesById(CategoryID: number): Observable<categoriesDto> {
    return this.http.get<categoriesDto>(this.apiUrl + "/" + CategoryID);
  }
}
