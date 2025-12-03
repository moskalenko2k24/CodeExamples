template<typename Deleter, typename Creator, typename ... Args>
auto make_unique_resource(Creator creator, Deleter deleter, Args && ... args) ->
    std::unique_ptr<std::remove_reference_t<decltype(*creator(std::forward<Args>(args)...))>, Deleter>
{
    return {creator(std::forward<Args>(args)...), deleter};
}
