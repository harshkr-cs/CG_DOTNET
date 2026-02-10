# TODO List for Fixing University Course Registration System

## 1. Fix Course.cs
- [ ] Fix EnrollStudent method: Change condition from MaxCapacity > 50 to IsFull()
- [ ] Remove NotImplementedException throws from HasPrerequisites, EnrollStudent, DropStudent

## 2. Fix Student.cs
- [ ] Fix CanAddCourse method: Correct logic for checking if course is already registered (invert the condition)
- [ ] Fix DropCourse method: Add check if course exists, return false if not found
- [ ] Remove NotImplementedException throws from GetTotalCredits, CanAddCourse, AddCourse, DropCourse, DisplaySchedule

## 3. Fix UniversitySystem.cs
- [ ] Fix AddCourse method: Remove NotImplementedException throw, fix exception message
- [ ] Fix AddStudent method: Remove NotImplementedException throw
- [ ] Fix RegisterStudentForCourse method: Remove NotImplementedException throw, improve messages
- [ ] Implement DropStudentFromCourse method
- [ ] Implement DisplayAllCourses method
- [ ] Implement DisplayStudentSchedule method
- [ ] Implement DisplaySystemSummary method

## 4. Fix Program.cs
- [ ] Implement menu case 1: Add Course with input prompts and validation
- [ ] Implement menu case 2: Add Student with input prompts and validation
- [ ] Implement menu case 3: Register Student for Course
- [ ] Implement menu case 4: Drop Student from Course
- [ ] Implement menu case 5: Display All Courses
- [ ] Implement menu case 6: Display Student Schedule
- [ ] Implement menu case 7: Display System Summary
- [ ] Implement menu case 8: Exit

## 5. Testing
- [ ] Compile the project
- [ ] Run the program and test basic functionality
- [ ] Test edge cases like full courses, prerequisites, credit limits
