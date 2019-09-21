import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-slide-show',
  templateUrl: './slide-show.component.html',
  styleUrls: ['./slide-show.component.scss']
})
export class SlideShowComponent{
   imagesUrl ={};
   
  constructor() { }

  ngOnInit() {
    
    this.imagesUrl = [
      'https://vignette.wikia.nocookie.net/animal-jam-clans-1/images/0/0a/Snowbranch.jpg/revision/latest?cb=20180107012032'
      ,'https://www.wcifly.com/images/medium/blog-pictures/oneweekinthailandfourkhaosoktrang8.jpg'
      ,'https://upload.wikimedia.org/wikipedia/commons/1/1e/%D9%85%D9%86%D8%A7%D8%B8%D8%B1_%D8%A8%D8%B1%D9%81%DB%8C_%D8%AC%D8%A7%D8%AF%D9%87_%D9%82%D9%85_%D8%A8%D9%87_%D8%AA%D9%81%D8%B1%D8%B4_-_%D8%A7%DB%8C%D8%B1%D8%A7%D9%86-_%D8%A8%D8%B1%D9%81_Snowy_landscape_of_Qom_province-_Iran_23.jpg'
      ,'https://upload.wikimedia.org/wikipedia/commons/7/71/مناظر_برفی_جاده_قم_به_تفرش_-_ایران-_برف_Snowy_landscape_of_Qom_province-_Iran_27.jpg'
      ,'../assets/A1.jpg'
      ,'../assets/A2.jpg'
      ,'../assets/A3.jpg'
    ] 
    }


}
