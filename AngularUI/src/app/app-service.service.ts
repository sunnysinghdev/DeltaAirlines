import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AppService {
  gridData: Student[] = [
    { id: 1, name: "Alice", age: 20, hobbies: ["reading", "swimming", "coding"] },
    { id: 2, name: "Bob", age: 22, hobbies: ["painting", "dancing", "singing"] },
  ];
  constructor() {

  }
  getData() {
    return new Observable((observer) => {
      observer.next(this.gridData);
      observer.complete();
    });
  }
}
export class Student {
  id: number | undefined;
  age: number | undefined;
  name: string | undefined;
  hobbies: string[] | undefined;
}
