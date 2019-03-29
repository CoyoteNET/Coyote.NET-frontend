var gulp = require('gulp');
var sass = require('gulp-sass');

 
//parse SCSS to pure CSS format   
   function scss_css(){
         return gulp.src('./src/scss/*.scss')
               .pipe(sass().on('error', sass.logError))
               .pipe(gulp.dest('src/'))   
    }

    
    
exports.scss_css = scss_css;
