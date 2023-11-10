#include "course.h"
#include "student.h"
#include <string>
#include <list>

course::course()
{
public:
    String name;
    String description;
private:
    list<student> enrolledStudents;
}
