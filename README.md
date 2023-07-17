# systemManaging-student

**System Documentation: Student Tracking Management System**
"Documentary images from the system below"

1. Introduction
The Student Tracking Management System is a software application developed in C# language to fulfill the requirements set by the college. The system aims to efficiently manage student information and provide features such as manual entry of student data, automatic entry of 10,000 random students, and generation of student reports sorted by grade point average. The development process follows the Test-Driven Development (TDD) methodology, ensuring robustness and reliability of the software.

2. Requirements
The system incorporates the following requirements:

2.1 Entering Student Information Manually
The application allows users to manually enter student information, including the ID, name, last name, email, telephone, and grades in five courses. Each course grade is represented on a scale of 0-100, with the option to enter 777 to indicate no grade.

2.2 Automatic Entry of 10,000 Students
The system provides an automated process to generate 10,000 student records with random information. This feature ensures a comprehensive dataset for testing and evaluation purposes.

2.3 Issuing a Student Report Sorted by Grade Point Average
The software generates a student report that is sorted based on the grade point average (GPA). The report provides an overview of student performance, facilitating easy identification of top-performing and low-performing students.

3. TDD Methodology
The development of the system strictly follows the Test-Driven Development (TDD) methodology. This approach involves writing tests before writing the code and continuously refactoring the code to improve its design and maintainability. The following TDD processes are performed:

3.1 TDD Process for Sort Function
The system incorporates a sorting function that initially implements the Bubble Sort algorithm (O(n^2)). The code is then optimized to achieve more efficient execution time (less than O(n^2)). The development process includes complete TDD practices, such as writing tests, implementing the code, and performing refactoring to enhance the sorting function.

3.2 TDD Process for Average Calculation Function
The software includes a function to calculate the average grade for each student. A TDD process is performed for this function, ensuring accurate calculations. Although refactoring is not mandatory for this function, it is encouraged for improving code quality.

4. Sorting Function
The sorting function in the system is implemented using the Bubble Sort algorithm. This function arranges the student records based on their grade point averages. To enhance efficiency, the code is optimized to achieve a faster execution time of less than O(n). Built-in sorting functions are not used to meet the requirements. The sorting function returns a sorted array and displays the time taken to sort on the screen.

5. Testing
To ensure the reliability and correctness of the system, unit tests are conducted for both the sorting function and the average calculation function. These tests verify that the functions return the expected results, that the student records remain intact, and that the array is sorted correctly. The DateTime.Now.Millisecond function is used to measure the execution time of the sorting function.

6. Version Control
Each version of the sorting function is saved as a comment within the code. Only the latest version is retained for use in the application. This approach allows for historical tracking of code modifications and maintains the most recent optimized version.

In conclusion, the Student Tracking Management System is a comprehensive software application developed in C# language using the TDD methodology. It provides features for manual and automatic entry of student information, sorting student records based on grade point average, and generating student reports. The system undergoes rigorous testing to ensure its reliability, and adherence to design principles is crucial.

login screen:
![LoginS](https://github.com/fkzx8000/systemManaging-student/assets/117019431/44fe62c7-140e-43e8-b35b-08a7aa9ec0a5)
Main screen:
![HomeS](https://github.com/fkzx8000/systemManaging-student/assets/117019431/0264c6fd-62c4-4804-8671-e0e092453f38)
