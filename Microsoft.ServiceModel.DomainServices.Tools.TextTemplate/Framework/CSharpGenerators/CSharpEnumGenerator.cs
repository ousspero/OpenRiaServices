﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 10.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace OpenRiaServices.DomainServices.Tools.TextTemplate.CSharpGenerators
{
    using System.Runtime.Serialization;
    using System.Reflection;
    using System.Collections.Generic;
    using System;
    using System.Linq;
    using OpenRiaServices.DomainServices.Tools;
    using OpenRiaServices.DomainServices.Server;
    
    #line 1 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class CSharpEnumGenerator : OpenRiaServices.DomainServices.Tools.TextTemplate.EnumGenerator
    {
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
        public override string TransformText()
        {
            this.GenerationEnvironment = null;
            this.Write("\r\n");
            this.Write("\r\n");
            this.Write("\r\n");
            this.Write("\r\n\r\n");
            
            #line 12 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
 this.Generate(); 
            
            #line default
            #line hidden
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 14 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
	
	private void GenerateEnumNamespace(Type enumType)
	{
		
        
        #line default
        #line hidden
        
        #line 17 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write("namespace ");

        
        #line default
        #line hidden
        
        #line 17 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(enumType.Namespace));

        
        #line default
        #line hidden
        
        #line 17 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"

	}
	
	private void GenerateEnumTypeDeclaration(Type enumType)
	{
		DataContractAttribute dataContractAttr = (DataContractAttribute)Attribute.GetCustomAttribute(enumType, typeof(DataContractAttribute));
        if (dataContractAttr != null)
        {
			this.GenerateDataContractAttribute(enumType);
		}
		
		if (enumType.GetCustomAttributes(typeof(FlagsAttribute), false).Length > 0)
        {

        
        #line default
        #line hidden
        
        #line 30 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write("[System.Flags]\r\n");

        
        #line default
        #line hidden
        
        #line 32 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"

		}
		
		
        
        #line default
        #line hidden
        
        #line 35 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write("public enum ");

        
        #line default
        #line hidden
        
        #line 35 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(CodeGenUtilities.GetSafeName(enumType.Name)));

        
        #line default
        #line hidden
        
        #line 35 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"

		
		Type underlyingType = enumType.GetEnumUnderlyingType();
        if (underlyingType != typeof(int))
		{
			
        
        #line default
        #line hidden
        
        #line 40 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(" : ");

        
        #line default
        #line hidden
        
        #line 40 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(CodeGenUtilities.GetTypeName(underlyingType)));

        
        #line default
        #line hidden
        
        #line 40 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"

		}
	}
	
	private void GenerateEnumMemberAttributes(FieldInfo fieldInfo)
	{	
		EnumMemberAttribute enumMemberAttr = (EnumMemberAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(EnumMemberAttribute));
        if (enumMemberAttr != null)
        {

        
        #line default
        #line hidden
        
        #line 49 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write("[System.Runtime.Serialization.EnumMember");

        
        #line default
        #line hidden
        
        #line 50 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"

            string value = enumMemberAttr.Value;
            if (!string.IsNullOrEmpty(value))
            {

        
        #line default
        #line hidden
        
        #line 54 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write("(Value=");

        
        #line default
        #line hidden
        
        #line 54 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(value.ToString()));

        
        #line default
        #line hidden
        
        #line 54 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(")\r\n");

        
        #line default
        #line hidden
        
        #line 55 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"

            }
        
        #line default
        #line hidden
        
        #line 56 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write("]");

        
        #line default
        #line hidden
        
        #line 56 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"

		}
		
		this.GenerateAttributes(fieldInfo.GetCustomAttributes(false).Cast<Attribute>().Where(a => a.GetType() != typeof(EnumMemberAttribute)));
	}
	
	private void GenerateEnumMembers(Type enumType)
	{
		Type underlyingType = enumType.GetEnumUnderlyingType();
		string[] memberNames = Enum.GetNames(enumType);
        Type enumValueType = Enum.GetUnderlyingType(enumType);
        for (int i = 0; i < memberNames.Length; ++i)
        {
            string memberName = memberNames[i];
			FieldInfo fieldInfo = enumType.GetField(memberName);
			
			this.GenerateEnumMemberAttributes(fieldInfo);
			
			if(fieldInfo != null)
			{
				object memberValue = fieldInfo.GetRawConstantValue();
				
				object[] minMaxValues = null;
               	CodeGenUtilities.IntegralMinMaxValues.TryGetValue(underlyingType, out minMaxValues);				
			
				if (minMaxValues != null && !memberValue.Equals(minMaxValues[2]) && memberValue.Equals(minMaxValues[0]))
				{

        
        #line default
        #line hidden
        
        #line 84 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(memberName));

        
        #line default
        #line hidden
        
        #line 84 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(" = ");

        
        #line default
        #line hidden
        
        #line 84 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(CodeGenUtilities.GetTypeName(underlyingType)));

        
        #line default
        #line hidden
        
        #line 84 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(".MinValue ");

        
        #line default
        #line hidden
        
        #line 84 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"

				}
				else if (minMaxValues != null && memberValue.Equals(minMaxValues[1]))
				{

        
        #line default
        #line hidden
        
        #line 88 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(" \r\n");

        
        #line default
        #line hidden
        
        #line 89 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(memberName));

        
        #line default
        #line hidden
        
        #line 89 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(" = ");

        
        #line default
        #line hidden
        
        #line 89 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(CodeGenUtilities.GetTypeName(underlyingType)));

        
        #line default
        #line hidden
        
        #line 89 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(".MaxValue ");

        
        #line default
        #line hidden
        
        #line 89 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"

				}
				else
				{

        
        #line default
        #line hidden
        
        #line 93 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(" \r\n");

        
        #line default
        #line hidden
        
        #line 94 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(memberName));

        
        #line default
        #line hidden
        
        #line 94 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(" = ");

        
        #line default
        #line hidden
        
        #line 94 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(memberValue.ToString()));

        
        #line default
        #line hidden
        
        #line 94 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(" ");

        
        #line default
        #line hidden
        
        #line 94 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"

				}
				
				if(i + 1 < memberNames.Length)
				{
					
        
        #line default
        #line hidden
        
        #line 99 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"
this.Write(",");

        
        #line default
        #line hidden
        
        #line 99 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpEnumGenerator.tt"

				}
			}
		}			
	}


        
        #line default
        #line hidden
        
        #line 5 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\Utility.ttinclude"


private void GenerateParameterDeclaration(IEnumerable<DomainOperationParameter> parameters, bool generateAttributes)
{
	DomainOperationParameter[] paramInfos = parameters.ToArray();
	for(int i = 0; i < paramInfos.Length; i++)
	{
		DomainOperationParameter paramInfo = paramInfos[i];
		if(generateAttributes)
		{
			IEnumerable<Attribute> paramAttributes = paramInfo.Attributes.Cast<Attribute>();
			this.GenerateAttributes(paramAttributes);
		}
		string paramTypeName = CodeGenUtilities.GetTypeName(CodeGenUtilities.TranslateType(paramInfo.ParameterType));
		string paramName = CodeGenUtilities.GetSafeName(paramInfo.Name);
		
        
        #line default
        #line hidden
        
        #line 20 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\Utility.ttinclude"
this.Write(this.ToStringHelper.ToStringWithCulture(paramTypeName));

        
        #line default
        #line hidden
        
        #line 20 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\Utility.ttinclude"
this.Write(" ");

        
        #line default
        #line hidden
        
        #line 20 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\Utility.ttinclude"
this.Write(this.ToStringHelper.ToStringWithCulture(paramName));

        
        #line default
        #line hidden
        
        #line 20 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\Utility.ttinclude"

		if(i + 1 < paramInfos.Length)
		{
			
        
        #line default
        #line hidden
        
        #line 23 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\Utility.ttinclude"
this.Write(", ");

        
        #line default
        #line hidden
        
        #line 23 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\Utility.ttinclude"

		}		
	}
}

private void GenerateOpeningBrace()
{

        
        #line default
        #line hidden
        
        #line 30 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\Utility.ttinclude"
this.Write("{\r\n");

        
        #line default
        #line hidden
        
        #line 32 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\Utility.ttinclude"

	PushIndent("\t");
}

private void GenerateClosingBrace()
{
	PopIndent();

        
        #line default
        #line hidden
        
        #line 39 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\Utility.ttinclude"
this.Write("}\r\n");

        
        #line default
        #line hidden
        
        #line 41 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\Utility.ttinclude"

}

private void GenerateNamespace(string ns)
{

        
        #line default
        #line hidden
        
        #line 46 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\Utility.ttinclude"
this.Write("namespace ");

        
        #line default
        #line hidden
        
        #line 47 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\Utility.ttinclude"
this.Write(this.ToStringHelper.ToStringWithCulture(ns));

        
        #line default
        #line hidden
        
        #line 47 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\Utility.ttinclude"
this.Write("\r\n");

        
        #line default
        #line hidden
        
        #line 48 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\Utility.ttinclude"

}


        
        #line default
        #line hidden
        
        #line 1 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"

	/// <summary>
	/// Generates attribute declarations in C#.
	/// </summary>
	/// <param name="attributes">The list of attributes to be generated.</param>
	protected virtual void GenerateAttributes(IEnumerable<Attribute> attributes)
	{	
		this.GenerateAttributes(attributes, false);
	}
	
	/// <summary>
	/// Generates attribute declarations in C#.
	/// </summary>
	/// <param name="attributes">The attributes to be generated.</param>
	/// <param name="forcePropagation">Causes the attributes to be generated even if the attribute verification fails.</param>
	protected virtual void GenerateAttributes(IEnumerable<Attribute> attributes, bool forcePropagation)
	{
		foreach (Attribute attribute in attributes.OrderBy(a => a.GetType().Name))
        {
			AttributeDeclaration attributeDeclaration = AttributeGeneratorHelper.GetAttributeDeclaration(attribute, this.ClientCodeGenerator, forcePropagation);
            if (attributeDeclaration == null || attributeDeclaration.HasErrors)
			{
				continue;
			}
			
			string attributeTypeName = CodeGenUtilities.GetTypeName(attributeDeclaration.AttributeType);

        
        #line default
        #line hidden
        
        #line 27 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write("[");

        
        #line default
        #line hidden
        
        #line 28 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write(this.ToStringHelper.ToStringWithCulture(attributeTypeName));

        
        #line default
        #line hidden
        
        #line 28 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 28 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"

			if (attributeDeclaration.ConstructorArguments.Count > 0)
            {
				for (int i = 0; i < attributeDeclaration.ConstructorArguments.Count; i++)
            	{
                	object value = attributeDeclaration.ConstructorArguments[i];
					string stringValue = AttributeGeneratorHelper.ConvertValueToCode(value, true);
					
        
        #line default
        #line hidden
        
        #line 35 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write(this.ToStringHelper.ToStringWithCulture(stringValue));

        
        #line default
        #line hidden
        
        #line 35 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"

					if (i + 1 < attributeDeclaration.ConstructorArguments.Count)
					{
					
        
        #line default
        #line hidden
        
        #line 38 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write(", ");

        
        #line default
        #line hidden
        
        #line 38 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"

					}
	            }
			}
			if (attributeDeclaration.NamedParameters.Count > 0)
            {
				if (attributeDeclaration.ConstructorArguments.Count > 0)
            	{
					
        
        #line default
        #line hidden
        
        #line 46 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write(", ");

        
        #line default
        #line hidden
        
        #line 46 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"

				}
				
				for (int i = 0; i < attributeDeclaration.NamedParameters.Count; i++)
                {
                    KeyValuePair<string, object> pair = attributeDeclaration.NamedParameters.ElementAt(i);
                    string stringValue = AttributeGeneratorHelper.ConvertValueToCode(pair.Value, true);
					
        
        #line default
        #line hidden
        
        #line 53 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write(this.ToStringHelper.ToStringWithCulture(pair.Key));

        
        #line default
        #line hidden
        
        #line 53 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write("=");

        
        #line default
        #line hidden
        
        #line 53 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write(this.ToStringHelper.ToStringWithCulture(stringValue));

        
        #line default
        #line hidden
        
        #line 53 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"

                    if (i + 1 < attributeDeclaration.NamedParameters.Count)
                    {
					
        
        #line default
        #line hidden
        
        #line 56 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write(",");

        
        #line default
        #line hidden
        
        #line 56 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"

                    }
                }
			}

        
        #line default
        #line hidden
        
        #line 60 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write(")]\r\n");

        
        #line default
        #line hidden
        
        #line 61 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"

		}
	}
	
	private void GenerateDataContractAttribute(Type sourceType)
	{
		string dataContractNamespace, dataContractName;
		AttributeGeneratorHelper.GetContractNameAndNamespace(sourceType, out dataContractNamespace, out dataContractName);

        
        #line default
        #line hidden
        
        #line 69 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write("[System.Runtime.Serialization.DataContract(Namespace = \"");

        
        #line default
        #line hidden
        
        #line 70 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write(this.ToStringHelper.ToStringWithCulture(dataContractNamespace));

        
        #line default
        #line hidden
        
        #line 70 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write("\"");

        
        #line default
        #line hidden
        
        #line 70 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
  
		if(!string.IsNullOrEmpty(dataContractName))
		{
		
        
        #line default
        #line hidden
        
        #line 73 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write(", Name = \" ");

        
        #line default
        #line hidden
        
        #line 73 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write(this.ToStringHelper.ToStringWithCulture(dataContractName));

        
        #line default
        #line hidden
        
        #line 73 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write("\"");

        
        #line default
        #line hidden
        
        #line 73 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"

		}

        
        #line default
        #line hidden
        
        #line 75 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"
this.Write(")]\r\n");

        
        #line default
        #line hidden
        
        #line 76 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\Templates\AttributeGeneratorTemplate.ttinclude"

	}	

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
