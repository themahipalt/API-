import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { User } from 'src/app/user';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  registerForm: FormGroup;
    submitted = false;

    constructor(private formBuilder: FormBuilder) { }

    ngOnInit() {
        this.registerForm = this.formBuilder.group({
            title: ['', Validators.required],
            firstName: ['', [Validators.required,
                Validators.pattern('^[a-z]{3,6}$')]],
            lastName: ['', Validators.required],
            mobile:['',[Validators.required,
                Validators.pattern("^[6-9][0-9]{9}$")]],
            email: ['', [Validators.required, Validators.email]],
            password: ['', [Validators.required, Validators.minLength(6)]],
            acceptTerms: [false, Validators.requiredTrue]
        });
    }

    // convenience getter for easy access to form fields
    get f() { return this.registerForm.controls; }

    onSubmit() {
        this.submitted = true;
         // display form values on success
        if (this.registerForm.valid) {
            alert('SUCCESS!! :-)\n\n') 
            console.log(JSON.stringify(this.registerForm.value));
            //assing form control values to model properties
            let user:User=new User();
            user.firstName=this.registerForm.value["firstname"]
            user.lastName=this.registerForm.value["lastname"]
            //once all model properties are assined we can service method to pass the model data to db table
            this.submitted=false;
            this.registerForm.reset();
        }
    }

    onReset() {
        this.submitted = false;
        this.registerForm.reset();
    }
}
