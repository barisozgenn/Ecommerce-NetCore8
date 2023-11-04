using System;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;

namespace Core.Aspects.Validation
{
    public class ValidationAspect: MethodInterception
    {
        private Type _validatorType;

        public ValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }
        
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(type: _validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];

            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);

            foreach (var entity in entities)
            {
                ValidationTool.Validatie(validator: validator, entity: entity);
            }

        }
    }
}

