#include "student.h"
#include "user.h"
#include "course.h"
#include <list>

student::student():private user
{
private:
    list<course> enrolledCourses;
}
