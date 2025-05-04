using EducationExample;

Teacher teacher = new Teacher("Dr. Alice");
Student s1 = new Student("Bob");
Student s2 = new Student("Eve");

Course course = new Course("Programming Basics", teacher);

course.EnrollStudent(s1);
course.EnrollStudent(s2);

teacher.PrintInfo();
s1.PrintInfo();

course.PrintCourseInfo();
