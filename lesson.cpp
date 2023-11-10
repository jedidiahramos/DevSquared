#include "lesson.h"
#include "course.h"
#include <string>

lesson::lesson(): public course
{
public:
    String title;
    String description;
}
