import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-random-book',
  templateUrl: './random-book.component.html',
  styleUrls: ['./random-book.component.css']
})

export class RandomBookComponent {
  public result: Book;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string) {
  }
  ngOnInit() {
    this.http.get<Book>(this.baseUrl + 'api').subscribe(result => {
      this.result = result;
    }, error => console.error(error));
  }
}


interface Book {
  name: string;
  author: string;
}
