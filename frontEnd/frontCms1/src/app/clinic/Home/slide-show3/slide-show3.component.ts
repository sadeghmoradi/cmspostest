import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-slide-show3',
  templateUrl: './slide-show3.component.html',
  styleUrls: ['./slide-show3.component.scss']
})
export class SlideShow3Component implements OnInit {
  images ={}
  
  list={}
  constructor() { 

    // ,{txt:'ss',url:'../assets/A1.jpg'}
    // ,{txt:'ss',url:'../assets/A2.jpg'}
    // ,{txt:'ss',url:'../assets/A3.jpg'}
  }

  ngOnInit() {
    this.images = [1, 2, 3,4].map(() => `https://picsum.photos/900/500?random&t=${Math.random()}`);
      this.list =[{img:this.images[1], title:'xzczxczcz',sub:'ss1'}
    ,{img:this.images[2], title:'xzczxczcz',sub:'ss2'}
    ,{img:this.images[3], title:'xzczxczcz',sub:'ss3'}
    // ,{img:this.images[4], title:'xzczxczcz',sub:'ss4'}
    ]
  }

}
