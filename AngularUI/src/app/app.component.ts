import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { AppService, Student } from './app-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  encapsulation: ViewEncapsulation.None,
})

export class AppComponent implements OnInit{
 
  title = 'AngularUI';
  gridData: any;
  constructor(private service: AppService){

  }
  ngOnInit(): void {
     this.service.getData().subscribe((res: any)=>{
      this.gridData = res;
     });
  }
  
}

