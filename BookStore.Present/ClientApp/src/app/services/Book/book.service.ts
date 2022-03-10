import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IBook } from 'src/app/models/IBook';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  constructor(private httpService:HttpClient) { }

  getAllBookks():Observable<IBook>
  {
    return this.httpService.get<IBook>(`${environment.APIURL}` + '/Book/Get');
  }
}
