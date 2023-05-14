//Является ли сравнение time и null в выражении if валидным? Почему?
static void Main()
{
    DateTime time;
    time = DateTime.Now;
    if (time == null)
    {
        //DateTime не является nullable типом по умолчанию, выражение if не валидно
    }

    DateTime? time1;
    time1 = DateTime.Now;
    if (time1 == null)
    {
        //DateTime приведен к nullable типу, выражение if валидно
    }
}

