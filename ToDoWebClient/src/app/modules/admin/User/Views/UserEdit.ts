// ALLOWOVERWRITE-30D3F5171A0FA787592579E2E7544095

import { Component,OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { ActivatedRoute, Params, Router }   from '@angular/router';
import { Location }                 from '@angular/common';

import {IUserView} from "../Models/UserView";
import {UserView} from "../Models/UserView";
import {UserService} from "../Services/UserService";

// Add service imports
    		
//Add Target Assoications    

   					
import {TaskService} from "../../Task/Services/TaskService"	
    		
// Add view Models Imports


// Add  Target Assoications view Models
 import { ITaskView } from "../../Task/Models/TaskView";
 

@Component({

  templateUrl: `./UserEdit.html`,
  providers: [
    UserService 

,TaskService
]
})





        export class UserEdit implements OnInit {
  userForm: FormGroup;
  userView: IUserView;
  userId: number=0;
    taskrows: any; 
  
  constructor(private formBuilder: FormBuilder, private userService: UserService, private route: ActivatedRoute, private router: Router, private location: Location
,private taskService: TaskService
  ) {

    this.userView=new UserView();
    //route.params.subscribe(params2 => {console.log(params2['id'])});
  }
        
        
        
         ngOnInit() {
    this.userForm = this.formBuilder.group({
	    				email: "", 
	    				firstName: "", 
	    				mobileNumber: "", 
	    				surname: "", 
	    				title: "", 
      
    });
         
       this.route.params.subscribe(params => {
        this.userId =params['id'];
          if (this.userId>0) {
        	this.userService.get(+params['id']).then(user => this.displayUser(user));
  			 this.taskService.getTasksByUser(this.userId).then(value => this.taskrows=value); 
      		}
      	});
      	
      	
      	
		
    }

  update() {
          const userModel = this.userForm.value;
          if (this.userId>0)
          {
            this.userService.update(this.userId,userModel).then(value => this.displayUser(value));
          }
          else
          {
          
          
            this.userService.add(userModel).then(value => this.router.navigateByUrl("/admin/user/edit/"+value.userId));
          }
      }

    displayUser(userView: UserView) {
    this.userForm.reset(userView);  	
	this.userView=userView;	    
    }
    
    
    deleteTask(taskId: number)
  	{
	    if (confirm('Are you sure you want to delete this?'))
	    {
	      this.taskService.remove(taskId).then();
	
	      for(var i = this.taskrows.length - 1; i >= 0; i--) {
	        if(this.taskrows[i].taskId === taskId) {
	          this.taskrows.splice(i, 1);
	          break;
	        }
	      }
	    }
  	}
  	
 }  
 
 
