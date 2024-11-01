using System;
using System.Collections.Generic;
using System.Text;
using Lombok.NET;

namespace ReflectionUebung
{
    [NoArgsConstructor]
    [AllArgsConstructor]
    [ToString]
    [With]
    public partial class Person
    {
        [Property]
        private string _vorname;
        [Property]
        private string _nachname;

    }

}
