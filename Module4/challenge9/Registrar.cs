using System;
using System.Collections.Generic;

namespace challenge9
{
    class Registrar
    {
        private List<IGraduate> grads;

        // public Registrar(List<IGraduate> grads)
        // {
        //     this.grads = grads;
        // }

        public Registrar(List<Student> students)
        {
            // Convert List<Student> to List<IGraduate>
            grads = new List<IGraduate>(students);
        }

        public void GraduateAll()
        {
            foreach (var graduate in grads)
            {
                graduate.Graduate();
            }
        }
    }
}
