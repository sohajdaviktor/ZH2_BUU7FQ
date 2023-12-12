function displayAllInstructors(data) {
    const allInstructorsContainer = document.getElementById('allInstructors');
    allInstructorsContainer.innerHTML = '';
    data.forEach(instructor => {
        const listItem = document.createElement('li');
        listItem.textContent = instructor;
        allInstructorsContainer.appendChild(listItem);
    });
}

function displayInstructorById(data) {
    const instructorByIdContainer = document.getElementById('instructorById');
    instructorByIdContainer.innerHTML = '';
    data.forEach(instructor => {
        const listItem = document.createElement('li');
        listItem.textContent = instructor;
        instructorByIdContainer.appendChild(listItem);
    });
}

function displayLessonsByInstructor(data) {
    const lessonsByInstructorContainer = document.getElementById('lessonsByInstructor');
    lessonsByInstructorContainer.innerHTML = '';
    data.forEach(lesson => {
        const listItem = document.createElement('li');
        listItem.textContent = `${lesson.instructor}: ${lesson.courseName}, ${lesson.day} ${lesson.time}, ${lesson.room}`;
        lessonsByInstructorContainer.appendChild(listItem);
    });
}

async function getAllInstructors() {
    const response = await fetch('/get/all');
    const data = await response.json();
    displayAllInstructors(data);
}

async function getInstructorById() {
    const id = document.getElementById('instructorId').value;
    const response = await fetch(`/get/instructorById?id=${id}`);
    const data = await response.json();
    displayInstructorById(data);
}

async function getLessonsByInstructor() {
    const name = document.getElementById('instructorName').value;
    const response = await fetch(`/get/lessonsByInstructor?name=${name}`);
    const data = await response.json();
    displayLessonsByInstructor(data);
}

async function addCourse() {
    const courseName = document.getElementById('courseName').value;
    const courseCode = document.getElementById('courseCode').value;
    const addCourseResult = document.getElementById('addCourseResult');

    const courseData = {
        courseSk: 0,
        name: courseName,
        code: courseCode,
        lessons: []
    };
    fetch('/post/addCourse', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(courseData)
    }).then(x => {
        if (x.ok) {
            addCourseResult.style.display = 'block';
            addCourseResult.textContent = `Course added successfully`;
            addCourseResult.style.color = 'green';
        } else {
            addCourseResult.style.display = 'block';
            addCourseResult.textContent = 'Failed to add course.';
            addCourseResult.style.color = 'red';
        }
    });
}