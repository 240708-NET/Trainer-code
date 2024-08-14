import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Post } from '../Models/post';
import { HttpClient } from '@angular/common/http';
import { Time } from '../Models/time';
import { Count } from '../Models/count';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  private JsonPlaceholder = 'https://jsonplaceholder.typicode.com';
  private helloapp = 'http://localhost:7262';

  constructor(private http: HttpClient) { }

  public getPosts(): Observable<Post[]>
  {
    return this.http.get<Post[]>(this.JsonPlaceholder + "/posts");
  }

  public getTime(): Observable<Time>
  {
    return this.http.get<Time>(this.helloapp + "/time");
  }

  public getCount(): Observable<Count>
  {
    return this.http.get<Count>(this.helloapp + "/count");
  }
}
