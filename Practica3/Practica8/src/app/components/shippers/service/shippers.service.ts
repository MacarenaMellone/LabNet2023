import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { shippersDto } from 'src/app/core/models/shippersDto';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ShippersService {
  endpoint: string = 'Shippers';
  apiUrl: string = environment.webApi + this.endpoint;
  
  constructor(private http: HttpClient) { }

  public getAllShippers(): Observable<Array<shippersDto>> {
    return this.http.get<Array<shippersDto>>(this.apiUrl);
  }
  
  public postShippers(shippersDto:shippersDto): Observable <any>{
    return this.http.post(this.apiUrl, shippersDto);
  } 

  public updateShippers(shippersDto: shippersDto): Observable<Object> {
    return this.http.put(this.apiUrl, shippersDto);
  }

  public deleteShippers(ShipperID: number): Observable<Object> {
    return this.http.delete<number>(this.apiUrl + "/" + ShipperID);
  }

  public getShippersById(ShipperID: number): Observable<shippersDto> {
    return this.http.get<shippersDto>(this.apiUrl + "/" + ShipperID);
  }
}
