#include <iostream>
#include <oatpp/network/Server.hpp>
#include <oatpp/web/server/HttpConnectionHandler.hpp>
#include <oatpp/network/tcp/server/ConnectionProvider.hpp>

class HelloHandler : public oatpp::web::server::HttpRequestHandler
{
public:
	std::shared_ptr<OutgoingResponse> handle(const std::shared_ptr<IncomingRequest>& request)
		override
	{
		return ResponseFactory::createResponse(Status::CODE_200, "I am Kira");
	}
};

void runserver()
{
	auto router = oatpp::web::server::HttpRouter::createShared();
	router->route("GET", "/hello", std::make_shared<HelloHandler>());
	auto connectionHandler = oatpp::web::server::HttpConnectionHandler::createShared(router);
	auto connectionProvider = oatpp::network::tcp::server::ConnectionProvider::createShared({ "localhost", 8000, oatpp::network::Address::IP_4 });

	oatpp::network::Server server(connectionProvider, connectionHandler);
	server.run();
}


int main() {
	oatpp::base::Environment::init();
	runserver;

	return 0;
}
