import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-slide-show3',
  templateUrl: './slide-show3.component.html',
  styleUrls: ['./slide-show3.component.scss']
})
export class SlideShow3Component implements OnInit {
  images ={}
  
     imagesUrl = {}
  list={}
  constructor() { 
  
  }

  ngOnInit() {
  
    this.images = [1, 2, 3,4].map(() => `https://picsum.photos/900/500?random&t=${Math.random()}`);

    this.imagesUrl =[1, 2, 3].map(()=> [
      ,'../assets/A1.jpg'
      ,'../assets/A2.jpg'
      ,'../assets/A3.jpg'
    ] );
    

    this.list =[{img:this.images[1], title:'xzczxczcz',sub:'ss1'}
    ,{img:this.images[2], title:'xzczxczcz',sub:'ss2'}
    ,{img:this.images[3], title:'xzczxczcz',sub:'ss3'}
    // ,{img:this.images[4], title:'xzczxczcz',sub:'ss4'}
    ]
  }

}
