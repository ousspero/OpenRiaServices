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
    using OpenRiaServices.DomainServices;
    using OpenRiaServices.DomainServices.Server;
    using OpenRiaServices.DomainServices.Server.ApplicationServices;
    using System.Linq;
    using System.Collections.Generic;
    using System;
    
    
    #line 1 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class CSharpWebContextGenerator : OpenRiaServices.DomainServices.Tools.TextTemplate.WebContextGenerator
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
            
            #line 10 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"
 this.Generate(); 
            
            #line default
            #line hidden
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 12 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"
 
	private void GenerateNamespace()
	{
		string ns = this.ClientCodeGenerator.Options.ClientRootNamespace;

        
        #line default
        #line hidden
        
        #line 16 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"
this.Write("namespace ");

        
        #line default
        #line hidden
        
        #line 17 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(ns));

        
        #line default
        #line hidden
        
        #line 17 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"
this.Write("\r\n");

        
        #line default
        #line hidden
        
        #line 18 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"

	}
	
	/// <summary>
	/// Generates the class declaration for the WebContext class.
	/// </summary>
	protected virtual void GenerateClassDeclaration()
	{

        
        #line default
        #line hidden
        
        #line 26 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"
this.Write("public sealed partial class WebContext : OpenRiaServices.DomainServices.Clien" +
        "t.ApplicationServices.WebContextBase\r\n");

        
        #line default
        #line hidden
        
        #line 28 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"

	}
	
	private void GenerateConstructor()
	{

        
        #line default
        #line hidden
        
        #line 33 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"
this.Write("public WebContext()\r\n{\t\t\t\r\n\tthis.OnCreated();\r\n}\r\n");

        
        #line default
        #line hidden
        
        #line 38 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"

	}
	
	/// <summary>
	/// Generates extensibility methods on the web context class.
	/// </summary>
	protected virtual void GenerateExtensibilityMethods()
	{

        
        #line default
        #line hidden
        
        #line 46 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"
this.Write("partial void OnCreated();\r\n");

        
        #line default
        #line hidden
        
        #line 48 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"

	}
	
	/// <summary>
	/// Generates the properties on the WebContext class.
	/// </summary>
	protected virtual void GenerateProperties()
	{

        
        #line default
        #line hidden
        
        #line 56 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"
this.Write("public new static WebContext Current\r\n{\r\n    get\r\n    {\r\n        return ((WebCont" +
        "ext)(OpenRiaServices.DomainServices.Client.ApplicationServices.WebContextBas" +
        "e.Current));\r\n    }\r\n}\r\n");

        
        #line default
        #line hidden
        
        #line 64 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"

		
		DomainServiceDescription defaultAuthDescription = this.GetDefaultAuthDescription();
		if(defaultAuthDescription != null)
		{
			Type genericType = null;
            typeof(IAuthentication<>).DefinitionIsAssignableFrom(defaultAuthDescription.DomainServiceType, out genericType);
            if ((genericType != null) && (genericType.GetGenericArguments().Count() == 1))
            {
				string typeName = CodeGenUtilities.GetTypeName(genericType.GetGenericArguments()[0]);

        
        #line default
        #line hidden
        
        #line 74 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"
this.Write("public new ");

        
        #line default
        #line hidden
        
        #line 75 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(typeName));

        
        #line default
        #line hidden
        
        #line 75 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"
this.Write(" User\r\n{\r\n\tget { return (");

        
        #line default
        #line hidden
        
        #line 77 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(typeName));

        
        #line default
        #line hidden
        
        #line 77 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"
this.Write(")base.User; }\r\n}\r\n");

        
        #line default
        #line hidden
        
        #line 79 "d:\dd\Alex_AppFx_1\src\AppFx\RiaServices\V1SP1\OpenRiaServices.DomainServices.Tools.TextTemplate\Framework\CSharpGenerators\CSharpWebContextGenerator.tt"

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
