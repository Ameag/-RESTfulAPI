using It_PlanetaApi.models.animal;
using It_PlanetaApi.repository;
using It_PlanetaApi.repository.animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.service.animal
{
    public class Animal : ServiceResponsibility, IAnimal
    {
        public Animal(Repository repository) : base(repository)
        {
        }

        public PostgresAnimal Create(CreateAnimalInput props)
        {
            if (props.AnimalTipes == null || props.AnimalTipes.Count <= 0)
            {
                ThrowInvalidRequestField("invalid animal tipes:{0}", props.AnimalTipes);
            }
            if (props.Weight == null || props.Weight <= 0)
            {
                ThrowInvalidRequestField("invalid weight:{0}", props.Weight);
            }
            if (props.Height == null || props.Height <= 0)
            {
                ThrowInvalidRequestField("invalid height:{0}", props.Height);
            }
            if (props.Length == null || props.Length <= 0)
            {
                ThrowInvalidRequestField("invalid lenght:{0}", props.Length);
            }
            if (props.Gender == null || props.Gender != "MALE" && props.Gender != "FEMALE" && props.Gender != "OTHER")
            {
                ThrowInvalidRequestField("invalid gender:{0}", props.Gender);
            }
            if (props.ChipperId == null || props.ChipperId <= 0)
            {
                ThrowInvalidRequestField("invalid chiperId:{0}", props.ChipperId);
            }
            //if (props.ChippingLocationId == null || props.ChippingLocationId <= 0)
            //{
            //    ThrowInvalidRequestField("invalid ChippingLocationId:{0}", props.ChippingLocationId);
            //}

            PostgresAnimal create = _repository.Animal.Create(
                props.Weight,
                props.Length,
                props.Height,
                props.Gender,
                props.ChipperId,
                props.ChippingLocationId);

            _repository.Animal.CreateAnimalTipes(props.AnimalTipes,create.Id);

            return create;
        }
    }
}
