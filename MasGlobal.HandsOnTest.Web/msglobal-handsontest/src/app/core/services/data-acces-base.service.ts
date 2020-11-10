import { Injectable } from '@angular/core';
import { Observable, of, throwError } from 'rxjs';
import { HttpClient, HttpErrorResponse, HttpResponse } from '@angular/common/http';
import { catchError, map, finalize } from 'rxjs/operators';
import { environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class DataAccesBaseService {

  private resourcePath = '';

  constructor(public http: HttpClient) { }

  public getList<T>(body: any): Observable<T[]> {
    return this.getting(body)
      .pipe<T[]>(map(this.extractData))
  }

  public get<T>(body: any): Observable<T> {
    return this.getting(body)
      .pipe<T>(map(this.extractData))
  }

  public get ResourcePath(): string {
    return this.resourcePath;
  }

  public set ResourcePath(resourcePath: string) {
    this.resourcePath = resourcePath;
  }

  private getting(body: any): Observable<any> {
    const url = environment.baseUrl + this.resourcePath;
    return this.http.get(url)
                    .pipe(catchError(this.handleError))
                  // .pipe(finalize(()=> this._loadingService.hideLoading()))                        
  }

  private extractData(res: HttpResponse<any>) {
    const body = res as any;
    return body;
  }


  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      console.error('There was a error:', error.error.message);
    } else {
      if(error.status == 404){
        return of(null)
      }
      console.error(
        `Status: ${error.status}, ` +
        `Body: ${error.error}`);
    }
    return throwError(
      'Ops, There was a communication problem with the server. Try it again later.');
  }
}
