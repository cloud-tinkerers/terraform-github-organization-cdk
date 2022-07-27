terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "~>3.10"
    }
  }
}

provider "azurerm" {
  features {
    resource_group {
      prevent_deletion_if_contains_resources = false
    }
  }
}

locals {
  environment   = "dev"
  database_name = "cdkbackend"
}

data "azurerm_client_config" "current" {}

resource "azurerm_resource_group" "rg" {
  name     = "cdk-backend-${local.environment}-mrb"
  location = "eastus"
}

module "azure_cosmos_db" {
  source                        = "Azure/cosmosdb/azurerm"
  resource_group_name           = azurerm_resource_group.rg.name
  location                      = azurerm_resource_group.rg.location
  cosmos_account_name           = "cdkbackenddev"
  cosmos_api                    = "sql"
  firewall_ip                   = ["192.24.221.222"]
  public_network_access_enabled = true
  ip_firewall_enabled           = true
  sql_dbs = {
    cdkbackend = {
      db_name           = local.database_name
      db_throughput     = 400
      db_max_throughput = null
    }
  }
  depends_on = [
    azurerm_resource_group.rg
  ]
}

output "cosmos_db" {
  value = {
    cosmosdb_connection_strings      = module.azure_cosmos_db.cosmosdb_connection_strings
    cosmosdb_endpoint                = module.azure_cosmos_db.cosmosdb_endpoint
    cosmosdb_id                      = module.azure_cosmos_db.cosmosdb_id
    cosmosdb_primary_key             = module.azure_cosmos_db.cosmosdb_primary_key
    cosmosdb_primary_readonly_key    = module.azure_cosmos_db.cosmosdb_primary_readonly_key
    cosmosdb_secondary_key           = module.azure_cosmos_db.cosmosdb_secondary_key
    cosmosdb_secondary_readonly_key  = module.azure_cosmos_db.cosmosdb_secondary_readonly_key
    cosmosdb_read_endpoint           = module.azure_cosmos_db.cosmosdb_read_endpoint
    cosmosdb_write_endpoint          = module.azure_cosmos_db.cosmosdb_write_endpoint
    cosmosdb_systemassigned_identity = module.azure_cosmos_db.cosmosdb_systemassigned_identity
    sql_containers_id                = module.azure_cosmos_db.sql_containers_id
    sql_db_id                        = module.azure_cosmos_db.sql_db_id
  }
  sensitive = true
}

# resource "azurerm_cosmosdb_account" "cosmosdb_account" {
#   name                = "cdk-backend-acct"
#   resource_group_name = azurerm_resource_group.rg.name
#   location            = azurerm_resource_group.rg.location
#   offer_type          = "Standard"

#   consistency_policy {
#     consistency_level = "Strong"
#   }

#   geo_location {
#     location          = "westus"
#     failover_priority = 0
#   }
# }

# resource "azurerm_cosmosdb_sql_database" "sql_db" {
#   name = "cdk-backend-db"
#   resource_group_name = azurerm_resource_group.rg.name
#   account_name = azurerm_cosmosdb_account.cosmosdb_account.name
# }

# resource "azurerm_cosmosdb_sql_container" "sql_container" {
#   name = "cdk-backend-db-container"
#   resource_group_name = azurerm_resource_group.rg.name
#   account_name = azurerm_cosmosdb_account.cosmosdb_account.name
#   database_name = azurerm_cosmosdb_sql_database.sql_db.name
#   partition_key_path = "/Requests"
# }

# resource "azurerm_cosmosdb_sql_role_definition" "current_client" {
#   name                = "examplesqlroledef"
#   resource_group_name = azurerm_resource_group.rg.name
#   account_name        = azurerm_cosmosdb_account.cosmosdb_account.name
#   type                = "CustomRole"
#   assignable_scopes   = ["/subscriptions/${data.azurerm_client_config.current.subscription_id}/resourceGroups/${azurerm_resource_group.rg.name}/providers/Microsoft.DocumentDB/databaseAccounts/${azurerm_cosmosdb_account.cosmosdb_account.name}"]

#   permissions {
#     data_actions = ["Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/items/all"]
#   }
# }

# resource "azurerm_cosmosdb_sql_role_assignment" "example" {
#   resource_group_name = azurerm_resource_group.rg.name
#   account_name        = azurerm_cosmosdb_account.cosmosdb_account.name
#   role_definition_id  = azurerm_cosmosdb_sql_role_definition.current_client.id
#   principal_id        = data.azurerm_client_config.current.object_id
#   scope               = "/subscriptions/${data.azurerm_client_config.current.subscription_id}/resourceGroups/${azurerm_resource_group.rg.name}/providers/Microsoft.DocumentDB/databaseAccounts/${azurerm_cosmosdb_account.cosmosdb_account.name}"
# }
